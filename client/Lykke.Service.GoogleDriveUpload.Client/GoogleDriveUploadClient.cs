﻿using System;
using Common.Log;

namespace Lykke.Service.GoogleDriveUpload.Client
{
    public class GoogleDriveUploadClient : IGoogleDriveUploadClient, IDisposable
    {
        private readonly ILog _log;

        public GoogleDriveUploadClient(string serviceUrl, ILog log)
        {
            _log = log;
        }

        public void Dispose()
        {
            //if (_service == null)
            //    return;
            //_service.Dispose();
            //_service = null;
        }
    }
}
