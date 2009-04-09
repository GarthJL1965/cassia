using System;
using System.Collections.Generic;

namespace Cassia
{
    /// <summary>
    /// Connection to a terminal server.
    /// </summary>
    public interface ITerminalServer : IDisposable
    {
        /// <summary>
        /// Underlying Windows handle for the terminal server.
        /// </summary>
        ITerminalServerHandle Handle { get; }

        /// <summary>
        /// Returns <c>true</c> if a connection to the server is currently open.
        /// </summary>
        bool IsOpen { get; }

        /// <summary>
        /// The name of the terminal server.
        /// </summary>
        string ServerName { get; }

        /// <summary>
        /// Lists the sessions on the terminal server.
        /// </summary>
        /// <returns>A list of sessions.</returns>
        IList<ITerminalServicesSession> GetSessions();

        /// <summary>
        /// Retrieves information about a particular session on the server.
        /// </summary>
        /// <param name="sessionId">The ID of the session.</param>
        /// <returns>Information about the requested session.</returns>
        ITerminalServicesSession GetSession(int sessionId);

        /// <summary>
        /// Opens a connection to the server.
        /// </summary>
        void Open();

        /// <summary>
        /// Closes the connection to the server.
        /// </summary>
        void Close();

        /// <summary>
        /// Retrieves a list of processes running on the terminal server.
        /// </summary>
        /// <returns>A list of processes.</returns>
        IList<ITerminalServicesProcess> GetProcesses();

        /// <summary>
        /// Retrieves information about a particular process running on the server.
        /// </summary>
        /// <param name="processId">The ID of the process.</param>
        /// <returns>Information about the requested process.</returns>
        ITerminalServicesProcess GetProcess(int processId);

        /// <summary>
        /// Shuts down the terminal server.
        /// </summary>
        /// <param name="type">Type of shutdown requested.</param>
        void Shutdown(ShutdownType type);
    }
}