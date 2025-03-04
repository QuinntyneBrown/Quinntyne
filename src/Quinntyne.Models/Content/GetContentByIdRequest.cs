// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using MediatR;

namespace Quinntyne.Models.Content;

public class GetContentByIdRequest: IRequest<GetContentByIdResponse>
{
    public Guid ContentId { get; set; }
}

