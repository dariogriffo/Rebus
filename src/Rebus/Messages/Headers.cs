// Copyright 2011 Mogens Heller Grabe
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
namespace Rebus.Messages
{
    public class Headers
    {
        /// <summary>
        /// Key of header that specifies the return address of a message.
        /// </summary>
        public const string ReturnAddress = "returnAddress";

        /// <summary>
        /// Key of header that contains an error message that stems from someone having experienced bad things trying to handle this message.
        /// </summary>
        public const string ErrorMessage = "errorMessage";
    }
}