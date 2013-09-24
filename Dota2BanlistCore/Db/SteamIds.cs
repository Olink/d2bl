/*
This file is part of Dota2Banlist.

Dota2Banlist is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Dota2Banlist is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Dota2Banlist.  If not, see <http://www.gnu.org/licenses/>.
*/

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dota2BanlistCore.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class SteamIds
    {
        public long Id { get; set; }
        public long SteamId_Y { get; set; }
        public long SteamId_Z { get; set; }
        public long SteamIdEncoded { get; set; }
        public string CurrentName { get; set; }
    }
}
