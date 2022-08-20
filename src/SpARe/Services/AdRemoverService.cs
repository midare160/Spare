﻿using SpARe.Services.FileSystem;

namespace SpARe.Services
{
    public class AdRemoverService : IAdRemoverService
    {
        private readonly IFileService _fileService;

        public AdRemoverService(IFileService fileService)
        {
            _fileService = fileService;
        }

        public Task RevertAsync()
        {
            return Task.CompletedTask;
        }

        public Task StartAsync()
        {
            return Task.CompletedTask;
        }
    }
}