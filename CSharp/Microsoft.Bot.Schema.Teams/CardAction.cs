// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Schema.Teams
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An action on a card
    /// </summary>
    public partial class CardAction
    {
        /// <summary>
        /// Initializes a new instance of the CardAction class.
        /// </summary>
        public CardAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CardAction class.
        /// </summary>
        /// <param name="type">Defines the type of action implemented by this
        /// button.</param>
        /// <param name="title">Text description which appear on the
        /// button.</param>
        /// <param name="image">URL Picture which will appear on the button,
        /// next to text label.</param>
        /// <param name="value">Supplementary parameter for action. Content of
        /// this property depends on the ActionType</param>
        public CardAction(string type = default(string), string title = default(string), string image = default(string), object value = default(object))
        {
            Type = type;
            Title = title;
            Image = image;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets defines the type of action implemented by this button.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets text description which appear on the button.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets URL Picture which will appear on the button, next to
        /// text label.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets supplementary parameter for action. Content of this
        /// property depends on the ActionType
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

    }
}
