using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RazorComponents.MaterialDesign
{
    public abstract class MdcComponentBase : ComponentBase
    {

        /// <summary>
        /// Gets or sets a collection of additional attributes that will be applied to the created element.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)] public IReadOnlyDictionary<string, object> AdditionalAttributes { get; set; }

        bool isFirstRender = true;

        protected override Task OnAfterRenderAsync()
        {
            if (isFirstRender)
            {
                isFirstRender = false;
                return OnAfterFirstRenderAsync();
            }
            else
            {
                return Task.CompletedTask;
            }
        }

        protected virtual Task OnAfterFirstRenderAsync()
            => Task.CompletedTask;
    }
}
