// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AddSlide.cs">
//   Copyright (c) 2018 Aspose.Slides for Cloud
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Xml.Serialization;

namespace Aspose.Slides.Cloud.Sdk.Model
{
    /// <summary>
    /// Add slide task.
    /// </summary>  
    public class AddSlide : Task 
    {                       
        /// <summary>
        /// File to clone a slide from.
        /// </summary>
        public InputFile CloneFromFile { get; set; }

        /// <summary>
        /// Position of the slide to clone.
        /// </summary>
        public int? CloneFromPosition { get; set; }

        /// <summary>
        /// Position at which to insert the slide.
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// Alias of layout (href, index or type). If value is null a blank slide is added.
        /// </summary>
        public string LayoutAlias { get; set; }


        /// <summary>
        /// Property values to determine the type when deserializing from Json
        /// </summary>
        public static Dictionary<string, object> TypeDeterminers
        {
            get
            {
                if (s_typeDeterminers == null)
                {
                    s_typeDeterminers = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                    s_typeDeterminers.Add("Type", TypeEnum.AddSlide);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public AddSlide() : base()
        {
            Type = TypeEnum.AddSlide;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class AddSlide {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  CloneFromFile: ").Append(this.CloneFromFile).Append("\n");
            sb.Append("  CloneFromPosition: ").Append(this.CloneFromPosition).Append("\n");
            sb.Append("  Position: ").Append(this.Position).Append("\n");
            sb.Append("  LayoutAlias: ").Append(this.LayoutAlias).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
