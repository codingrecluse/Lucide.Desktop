
using System.IO;
using System.Text.Json;
using System.Text;
using System.Windows.Media;
using Lucide.WPF.Enums;
using Svg;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection.Metadata;

namespace Lucide.WPF;

public class IconManager
{
    private static string _basePath = AppDomain.CurrentDomain.BaseDirectory;


  /// <summary>
  /// Creates and returns an ImageSource file based on provided parameters.
  /// </summary>
  /// <param name="icon">Name of the icon.</param>
  /// <param name="color">Color (default is black)</param>
  /// <param name="height">Height of image (default is 128px)</param>
  /// <param name="width">Width of image (default is 128px)</param>
  /// <returns></returns>
  public static async Task<ImageSource?> CreateImageSource(IconName icon, System.Windows.Media.Color color, int height = 128, int width = 128)
  {
    var filePath = _basePath + "icons\\" + Enum.GetName(icon) + ".svg";
    if (color == null)
      color = Colors.Black;

    if (File.Exists(filePath))
    {
      var data = await File.ReadAllTextAsync(filePath);
      var colorString = $"rgba({color.R}, {color.G}, {color.B}, {color.A})";
      data = data.Replace("currentColor", colorString);
      var options = new SvgOptions();
      var document = SvgDocument.FromSvg<SvgDocument>(data);
      document.Height = height;
      document.Width = width;
      document.FillOpacity = 0;

      return GenerateSource(document.Draw());
    }
    else
      return null;

  }
  /// <summary>
  /// Creates and returns an ImageSource file based on provided parameters.
  /// </summary>
  /// <param name="icon">Name of the icon.</param>
  /// <param name="color">Color (default is black)</param>
  /// <param name="height">Height of image (default is 128px)</param>
  /// <param name="width">Width of image (default is 128px)</param>
  /// <returns></returns>
  public static async Task<ImageSource?> CreateImageSource(IconName icon, System.Drawing.Color color, int height = 128, int width = 128)
  {
    var filePath = _basePath + "icons\\" + Enum.GetName(icon) + ".svg";

    if (File.Exists(filePath))
    {
      var data = await File.ReadAllTextAsync(filePath);
      var colorString = $"rgba({color.R}, {color.G}, {color.B}, {color.A})";
      data = data.Replace("currentColor", colorString);
      var options = new SvgOptions();
      var document = SvgDocument.FromSvg<SvgDocument>(data);
      document.Height = height;
      document.Width = width;
      document.FillOpacity = 0;

      return GenerateSource(document.Draw());
    }
    else
      return null;

  }

  /// <summary>
  /// Creates and returns a Bitmap file based on provided parameters.
  /// </summary>
  /// <param name="icon">Name of the icon.</param>
  /// <param name="color">Color (default is black)</param>
  /// <param name="height">Height of image (default is 128px)</param>
  /// <param name="width">Width of image (default is 128px)</param>
  /// <returns></returns>
  public static async Task<Bitmap?> CreateBitmap(IconName icon, System.Windows.Media.Color color, int height = 128, int width = 128)
  {
    var filePath = _basePath + "icons\\" + Enum.GetName(icon) + ".svg";

    if (File.Exists(filePath))
    {
      var data = await File.ReadAllTextAsync(filePath);
      var colorString = $"rgba({color.R}, {color.G}, {color.B}, {color.A})";
      data = data.Replace("currentColor", colorString);
      var options = new SvgOptions();
      var document = SvgDocument.FromSvg<SvgDocument>(data);
      document.Height = height;
      document.Width = width;
      document.FillOpacity = 0;

      return document.Draw();
    }
    else
      return null;

  }


  /// <summary>
  /// Creates and returns a Bitmap file based on provided parameters.
  /// </summary>
  /// <param name="icon">Name of the icon.</param>
  /// <param name="color">Color (default is black)</param>
  /// <param name="height">Height of image (default is 128px)</param>
  /// <param name="width">Width of image (default is 128px)</param>
  /// <returns></returns>
  public static async Task<Bitmap?> CreateBitmap(IconName icon, System.Drawing.Color color, int height = 128, int width = 128)
  {
    var filePath = _basePath + "icons\\" + Enum.GetName(icon) + ".svg";

    if (File.Exists(filePath))
    {
      var data = await File.ReadAllTextAsync(filePath);
      var colorString = $"rgba({color.R}, {color.G}, {color.B}, {color.A})";
      data = data.Replace("currentColor", colorString);
      var options = new SvgOptions();
      var document = SvgDocument.FromSvg<SvgDocument>(data);
      document.Height = height;
      document.Width = width;
      document.FillOpacity = 0;

      return document.Draw();
    }
    else
      return null;

  }/// <summary>
   /// Creates and returns a basic System.Drawing.Image file based on provided parameters.
   /// </summary>
   /// <param name="icon">Name of the icon.</param>
   /// <param name="color">Color (default is black)</param>
   /// <param name="height">Height of image (default is 128px)</param>
   /// <param name="width">Width of image (default is 128px)</param>
   /// <returns></returns>
  public static async Task<Image?> CreateImage(IconName icon, System.Windows.Media.Color color, int height = 128, int width = 128)
    {
        var filePath = _basePath + "icons\\" + Enum.GetName(icon) + ".svg";

        if (File.Exists(filePath))
        {
            var data = await File.ReadAllTextAsync(filePath);
            var colorString = $"rgba({color.R}, {color.G}, {color.B}, {color.A})";
            data = data.Replace("currentColor", colorString);
            var options = new SvgOptions();
            var document = SvgDocument.FromSvg<SvgDocument>(data);
            document.Height = height;
            document.Width = width;
            document.FillOpacity = 0;

            return document.Draw();
        }
        else
            return null;
    }

  /// <summary>
  /// Creates and returns a basic System.Drawing.Image file based on provided parameters.
  /// </summary>
  /// <param name="icon">Name of the icon.</param>
  /// <param name="color">Color (default is black)</param>
  /// <param name="height">Height of image (default is 128px)</param>
  /// <param name="width">Width of image (default is 128px)</param>
  /// <returns></returns>
  public static async Task<Image?> CreateImage(IconName icon, System.Drawing.Color color, int height = 128, int width = 128)
  {
    var filePath = _basePath + "icons\\" + Enum.GetName(icon) + ".svg";

    if (File.Exists(filePath))
    {
      var data = await File.ReadAllTextAsync(filePath);
      var colorString = $"rgba({color.R}, {color.G}, {color.B}, {color.A})";
      data = data.Replace("currentColor", colorString);
      var options = new SvgOptions();
      var document = SvgDocument.FromSvg<SvgDocument>(data);
      document.Height = height;
      document.Width = width;
      document.FillOpacity = 0;

      return document.Draw();
    }
    else
      return null;
  }
  private static ImageSource? GenerateSource(Bitmap bitmap)
    {
        var bitmapData =
            bitmap.LockBits(
                new Rectangle(0, 0,
                bitmap.Width,
                bitmap.Height),
                ImageLockMode.ReadOnly,
                bitmap.PixelFormat);

        var bitmapSource =
            BitmapSource.Create(
            bitmapData.Width,
            bitmapData.Height,
            bitmap.HorizontalResolution,
            bitmap.VerticalResolution,
            PixelFormats.Bgra32,
            null,
            bitmapData.Scan0,
            bitmapData.Stride * bitmapData.Height,
            bitmapData.Stride);

        bitmap.UnlockBits(bitmapData);

        return bitmapSource;
    }

    /// <summary>
    /// Provides a list of available icon names that match desired category.
    /// </summary>
    /// <param name="category">Desired icon category.</param>
    /// <returns></returns>
    public static async Task<List<IconName>?> FilterIconsByCategory(IconCategory category)
    {
        var iconDirectory = _basePath + "icons\\";
        List<IconName>? results = null;

        if (Directory.Exists(iconDirectory))
        {
            foreach (var iconFile in Directory.GetFiles(iconDirectory, "*.json"))
            {
                var data = await File.ReadAllTextAsync(iconFile);
                var jObject = JsonDocument.Parse(data).Deserialize<JsonElement>();
                foreach (var cat in jObject.GetProperty("categories").Deserialize<string[]>() ?? [])
                {
                    if (Enum.TryParse<IconCategory>(cat, out var parsedCategory))
                    {
                        if (parsedCategory == category)
                        {
                            var fileName = Path.GetFileName(iconFile);
                            if (Enum.TryParse<IconName>(fileName.Split('.')[0], out var parsedIcon))
                            {
                                if (results == null)
                                    results = new List<IconName>();
                                if (!results.Contains(parsedIcon))
                                    results.Add(parsedIcon);
                            }
                        }
                    }
                }
            }
        }

        return results;
    }
}

