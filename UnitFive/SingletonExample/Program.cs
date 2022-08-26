using SingletonExample;

MySingleton singleton = MySingleton.GetInstance();

singleton.MyData.Add("data 1");
singleton.MyData.Add("data 2");
singleton.PrintData();

MySingleton singleton2 = MySingleton.GetInstance();
singleton2.MyData.Add("data 3");

MySingleton singleton3 = MySingleton.GetInstance();
singleton3.PrintData();