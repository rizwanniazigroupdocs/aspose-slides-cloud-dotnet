
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostAddNewSubshapePortionRequest.cs">
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

using System.Collections.Generic;
using System.IO;
using Aspose.Slides.Cloud.Sdk.Model;

namespace Aspose.Slides.Cloud.Sdk.Model.Requests 
{
  /// <summary>
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PostAddNewSubshapePortion" /> operation.
  /// </summary>  
  public class PostAddNewSubshapePortionRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAddNewSubshapePortionRequest"/> class.
        /// </summary>        
        public PostAddNewSubshapePortionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAddNewSubshapePortionRequest"/> class.
        /// </summary>
        /// <param name="name">Document name.</param>
        /// <param name="slideIndex">Slide index.</param>
        /// <param name="shapeIndex">Shape index.</param>
        /// <param name="paragraphIndex">Paragraph index.</param>
        /// <param name="dto">Portion DTO.</param>
        /// <param name="path">Shape path.</param>
        /// <param name="password">Document password.</param>
        /// <param name="folder">Document folder.</param>
        /// <param name="storage">Document storage.</param>
        /// <param name="position">Position of the new portion in the list. Default is at the end of the list.</param>
        public PostAddNewSubshapePortionRequest(string name, int slideIndex, int shapeIndex, int paragraphIndex, Portion dto, string path = null, string password = null, string folder = null, string storage = null, int? position = null)
        {
            this.Name = name;
            this.SlideIndex = slideIndex;
            this.ShapeIndex = shapeIndex;
            this.ParagraphIndex = paragraphIndex;
            this.Dto = dto;
            this.Path = path;
            this.Password = password;
            this.Folder = folder;
            this.Storage = storage;
            this.Position = position;
        }

        /// <summary>
        /// Document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Slide index.
        /// </summary>  
        public int SlideIndex { get; set; }

        /// <summary>
        /// Shape index.
        /// </summary>  
        public int ShapeIndex { get; set; }

        /// <summary>
        /// Paragraph index.
        /// </summary>  
        public int ParagraphIndex { get; set; }

        /// <summary>
        /// Portion DTO.
        /// </summary>  
        public Portion Dto { get; set; }

        /// <summary>
        /// Shape path.
        /// </summary>  
        public string Path { get; set; }

        /// <summary>
        /// Document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Position of the new portion in the list. Default is at the end of the list.
        /// </summary>  
        public int? Position { get; set; }
  }
}