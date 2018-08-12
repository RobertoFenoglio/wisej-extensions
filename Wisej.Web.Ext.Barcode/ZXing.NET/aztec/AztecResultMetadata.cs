﻿/*
 * Copyright 2013 ZXing authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace ZXing.Aztec
{
   /// <summary>
   /// Aztec result meta data.
   /// </summary>
   public sealed class AztecResultMetadata
   {
      /// <summary>
      /// Returns a value indicating whether this Aztec code is compact.
      /// </summary>
      /// <value>
      ///   <c>true</c> if compact; otherwise, <c>false</c>.
      /// </value>
      public bool Compact { get; private set; }
      /// <summary>
      /// Returns the nb datablocks.
      /// </summary>
      public int Datablocks { get; private set; }
      /// <summary>
      /// Returns the nb layers.
      /// </summary>
      public int Layers { get; private set; }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="compact"></param>
      /// <param name="datablocks"></param>
      /// <param name="layers"></param>
      public AztecResultMetadata(bool compact, int datablocks, int layers)
      {
         Compact = compact;
         Datablocks = datablocks;
         Layers = layers;
      }
   }
}