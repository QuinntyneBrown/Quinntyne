// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using MediatR;
using System.Text.Json;

namespace Quinntyne.Models.Content;

public class UpdateContentRequest: IRequest<UpdateContentResponse>
{
    public Guid ContentId { get; set; }
    public string Name { get; set; }
    public JsonElement Body { get; set; }
}

