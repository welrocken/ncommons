﻿namespace NCommons.Eroman
{
    public interface IError
    {
        int Code { get; }
        string Message { get; }
    }
}