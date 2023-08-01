using N16Home2;
using N16Home2.SmartHomeService;

SmartHome obj = new SmartHome();

obj.Activated();
obj.Temperature(20, 22);
obj.Temperature(25, 26);
obj.Temperature(20, 20);
obj.Temperature(23, 22);
obj.Temperature(21, 21);
obj.DisplayHomeTemperature();