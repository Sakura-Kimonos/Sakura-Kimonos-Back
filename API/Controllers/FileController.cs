﻿using API.IServices;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.IO.Compression;
using System.Net.Mime;


namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class FileController
    {
        private readonly IFileService _fileService;
        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost(Name = "PostFile")]
        public int PostFile([FromForm] FileUploadModel fileUploadModel)
        {
            try
            {
                var fileItem = new FileItem();
                fileItem.Id = 0;
                fileItem.Name = fileUploadModel.File.FileName;
                fileItem.InsertDate = DateTime.Now;
                fileItem.UpdateDate = DateTime.Now;
                fileItem.FileExtension = fileUploadModel.FileExtension;

                using (var stream = new MemoryStream())
                {
                    fileUploadModel.File.CopyTo(stream);
                    fileItem.Content = stream.ToArray();
                }

                return _fileService.InsertFile(fileItem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet(Name = "GetFileById")]
        public FileStreamResult GetFileById(int id)
        {
            try
            {
                var fileItem = _fileService.GetFileById(id);
                var stream = new MemoryStream(fileItem.Content);
                var mimeType = MediaTypeNames.Image.Jpeg.ToString();
                return new FileStreamResult(stream, new MediaTypeHeaderValue(mimeType))
                {
                    FileDownloadName = fileItem.Name
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet(Name = "GetAllImagesList")]
        public List<FileItem> GetAllImagesList()
        {
            return _fileService.GetAllImagesList();
        }

        [HttpGet(Name = "GetAllFilesZip")]
        public FileStreamResult GetAllFilesZip()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //required: using System.IO.Compression;
                using (var zip = new ZipArchive(ms, ZipArchiveMode.Create, true))
                {
                    //QUery the Products table and get all image content
                    _fileService.GetAllImagesList().ForEach(file =>
                    {
                        var entry = zip.CreateEntry(file.Name);
                        using (var fileStream = new MemoryStream(file.Content))
                        using (var entryStream = entry.Open())
                        {
                            fileStream.CopyTo(entryStream);
                        }
                    });
                }
                return new FileStreamResult(ms, MediaTypeNames.Application.Zip)
                {
                    FileDownloadName = "images.zip"
                };
            }
        }
    }
}
