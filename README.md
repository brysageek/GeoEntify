# GeoEntify

**GeoEntify** is a powerful class library designed to simplify the process of mapping GIS features to entities. Built on the ArcGIS Runtime SDK for .NET, GeoEntify exposes the underlying attributes of `GeoElement` and offers robust functionality for mapping model properties to named properties. Future enhancements will include Coded Value Domain lookup and resolution.

## Features

- **ArcGIS Runtime SDK Integration**: Leverages the `GeoElement` class from the ArcGIS Runtime SDK for .NET to provide a solid foundation for GIS feature handling.
- **Attribute Exposure**: Easily access and manipulate the underlying attributes of `GeoElement`.
- **Property Mapping**: Map model properties to named properties for seamless integration with your applications.
- **Future Roadmap**: Plans to include Coded Value Domain lookup and resolution for enhanced data interpretation.

## Getting Started

### Prerequisites

- .NET 6.0 or later
- ArcGIS Runtime SDK for .NET

### Installation

To install GeoEntify, add the following package to your project:

```powershell
dotnet add package Brysageek.GeoEntify
```

### Usage

Here's a basic example of how to use GeoEntify in your project:

```csharp
using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Brysageek.GeoEntify;

public class GeoEntityExample
{
    public async Task RunExample()
    {
        // Initialize the map and layer
        var map = new Map(BasemapStyle.ArcGISImageryStandard);
        var featureLayer = new FeatureLayer(new Uri("https://your-feature-layer-url"));

        // Load the layer
        await featureLayer.LoadAsync();

        // Query features
        var queryParams = new QueryParameters
        {
            WhereClause = "1=1"
        };
        var result = await featureLayer.FeatureTable.QueryFeaturesAsync(queryParams);

        // Convert features to GeoEntities
        var geoEntities = result.Select(feature => new GeoEntity(feature)).ToList();

        // Access attributes
        foreach (var geoEntity in geoEntities)
        {
            Console.WriteLine($"ID: {geoEntity.ObjectId}");
            Console.WriteLine($"Name: {geoEntity.Name}");
        }
    }
}
```

## Roadmap

- **Coded Value Domain Lookup and Resolution**: Future versions of GeoEntify will include functionality to look up and resolve coded value domains, making it easier to interpret and work with domain-specific data.

## License

GeoEntify is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.



---
