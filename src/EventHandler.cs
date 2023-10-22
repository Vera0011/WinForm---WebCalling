using System.Net;
using System.Text.RegularExpressions;

namespace WebCalling;

public static class EventHandler
{
    static readonly HttpClient client = new HttpClient();

    public static async void executeSearch(object sender, EventArgs args)
    {
        string urlText = Application.OpenForms[0].Controls["url_textbox"].Text;
        string wordText = Application.OpenForms[0].Controls["word_textbox"].Text;

        if (!string.IsNullOrWhiteSpace(urlText) && !string.IsNullOrWhiteSpace(wordText))
        {
            string urlTextSanitized = urlText.Trim();
            string wordTextSanitized = wordText.Trim();
            Uri urlChecked;

            try
            {
                if (
                    Uri.TryCreate(urlTextSanitized, UriKind.Absolute, out urlChecked)
                    && (urlChecked.Scheme == Uri.UriSchemeHttps)
                )
                {
                    string responseBody = await client.GetStringAsync(urlChecked);

                    WindowDialog.ShowDialog(
                        "Veces que la palabra "
                            + wordTextSanitized
                            + " se ha encontrado: "
                            + countWords(responseBody, wordTextSanitized),
                        "WebCalling - Response",
                        "./src/img/icon.ico"
                    );
                }
                else
                    WindowDialog.ShowDialog(
                        "La URL especificada no es válida",
                        "WebCalling - Error",
                        "./src/img/error.ico"
                    );
            }
            catch (System.Exception error)
            {
                WindowDialog.ShowDialog(
                    "No se puede acceder a la web especificada",
                    "WebCalling - Error",
                    "./src/img/error.ico"
                );
            }
        }
        else
            WindowDialog.ShowDialog(
                "Por favor, rellene todos los campos",
                "WebCalling - Error",
                "./src/img/error.ico"
            );
    }

    public static void exitProgram(object sender, EventArgs args)
    {
        Application.Exit();
    }

    private static int countWords(string input, string wordText)
    {
        int wordCounter = 0;

        foreach (string value in input.Split(" "))
        {
            if ((value.ToLower()).Contains(wordText.ToLower()))
                wordCounter++;
        }

        return wordCounter;
    }
}
