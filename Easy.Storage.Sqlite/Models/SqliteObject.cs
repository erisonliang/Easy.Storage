﻿// ReSharper disable UnassignedGetOnlyAutoProperty
namespace Easy.Storage.Sqlite.Models
{
    /// <summary>
    /// Represents objects defined in a <c>SQLite</c> database.
    /// </summary>
    public sealed class SqliteObject
    {
        /// <summary>
        /// Gets the type of the object.
        /// </summary>
        public SqliteObjectType Type { get; }

        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the <c>SQL</c> query used to define the object.
        /// </summary>
        public string Sql { get; }
    }
}