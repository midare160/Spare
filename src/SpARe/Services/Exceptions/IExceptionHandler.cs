﻿namespace SpARe.Services.Exceptions
{
    public interface IExceptionHandler
    {
        void OnAppDomainException(object sender, UnhandledExceptionEventArgs e);
        void OnThreadException(object sender, ThreadExceptionEventArgs e);
    }
}