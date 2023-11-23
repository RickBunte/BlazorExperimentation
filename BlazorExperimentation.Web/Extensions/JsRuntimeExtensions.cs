using Microsoft.JSInterop;

namespace BlazorExperimentation.Web.Extensions
{
    public static class JsRuntimeExtensions
    {
        /// <summary>
        /// Enables the JavaScript command "console.log" to be called upon for easier live object reading.
        /// </summary>
        /// <param name="jsRuntime">JS Runtime.</param>
        /// <param name="args">The passed object.</param>
        /// <returns></returns>
        public static async Task LogAsync(this IJSRuntime jsRuntime, params object?[]? args)
        {
            await jsRuntime.InvokeVoidAsync("console.log", args);
        }
    }
}
