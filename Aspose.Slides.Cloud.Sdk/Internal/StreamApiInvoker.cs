// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StringToObjectApiInvoker.cs">
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

namespace Aspose.Slides.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.IO;

    internal class StreamApiInvoker : ApiInvoker<object, Stream>
    {
        public StreamApiInvoker(List<IRequestHandler> requestHandlers) : base(requestHandlers)
        {
        }

        protected override void CopyToStream(Stream data, Stream stream)
        {
            if (data.CanSeek)
            {
                data.Flush();
                data.Position = 0;
            }

            byte[] array = new byte[81920];
            int count;
            while ((count = data.Read(array, 0, array.Length)) != 0)
            {
                stream.Write(array, 0, count);
            }
        }
    }
}
