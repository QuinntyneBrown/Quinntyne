// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Quinntyne.Models.Content;

public static class ContentExtensions
{
    public static ContentDto ToDto(this Content content)
    {
        return new ContentDto()
        {
            ContentId = content.ContentId,
            Name = content.Name,
            Body = content.Body,
        };

    }

}

