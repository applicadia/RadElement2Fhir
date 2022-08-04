﻿using RadElement2Fhir;

try
{
    if (args.Length != 1)
        throw new Exception($"Missing erquired option file path");
    Options options = Options.Load(args[0]);
    RadElementToFhir processor = new RadElementToFhir(options);
    processor.Execute().Wait();
    return 0;
}
catch(Exception err)
{
    Console.WriteLine(err.Message);
    return -1;
}