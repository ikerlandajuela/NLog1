## 1.0.0 (2017-08-05) 

**Autor: Iker Landajuela**

Features:

* `App.config` añado bloque `<appSettings>` con versión aplicación. Para usar App.config en la aplicación hay que añadir además en referencias del proyecto System.Configuration. 	

Bloque `<appSettings>`: 

```
<appSettings>
	<add key="version" value="1.0.0" />
</appSettings>`
```

* `Program.cs`: Añadimos espacio de nombres `using System.Configuration;` y obtenemos información de versión 

Uso:

```
string appSettings_version = ConfigurationManager.AppSettings["version"];
```

```
Console.WriteLine("Version {0}",appSettings_version);            
```

