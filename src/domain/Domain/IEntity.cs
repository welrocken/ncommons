﻿namespace NCommons.Domain
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}