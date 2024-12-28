// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Text.Json;

namespace Quinntyne.Models.Content;

public class ContentDto
{
    public Guid ContentId { get; set; }
    public string Name { get; set; }
    public JsonElement Body { get; set; }
}

