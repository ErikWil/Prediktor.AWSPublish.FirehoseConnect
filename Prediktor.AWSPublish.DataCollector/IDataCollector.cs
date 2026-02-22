using System;
using System.Collections.Generic;

namespace Prediktor.AWSPublish.DataCollector
{
    public interface IDataCollector
    {
        /// <summary>
        /// Connects to a Hive using the provided connection parameters.
        /// </summary>
        /// <param name="HiveConnection">Connection parameters for Hive.</param>
        void Connect(ConnectionParameters HiveConnection);

        /// <summary>
        /// Runs the data collection, invoking the callback on a sequence of Status<VQT> objects.
        /// </summary>
        /// <param name="callback">Callback function accepting the sequence of Status<VQT>.</param>
        void Run(Func<IEnumerable<Status<VQT>>, bool> callback);
    }
}