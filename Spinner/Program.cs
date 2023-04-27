using Spinner.classes;

Spinners spinner = new Spinners(10, 10);

spinner.Start();

// Do your work here instead of sleeping...
Thread.Sleep(10000);

spinner.Stop();