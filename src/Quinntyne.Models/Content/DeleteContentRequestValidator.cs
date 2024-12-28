// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using FluentValidation;

namespace Quinntyne.Models.Content;

public class DeleteContentRequestValidator: AbstractValidator<DeleteContentRequest>
{
    public DeleteContentRequestValidator(){
        RuleFor(x => x.ContentId).NotNull();

    }

}

