# Prediktor.AWSPublish.DataCollector

A C# interface for data collection connectors supporting Hive connection and callback-driven data processing.

## Features

- `IDataCollector`: 
    - `Connect(ConnectionParameters HiveConnection)`
    - `Run(Func<IEnumerable<Status<VQT>>, bool> callback)`

> Types `ConnectionParameters`, `Status<T>`, and `VQT` must be defined by your implementation or domain library.

## License

Copyright © Prediktor