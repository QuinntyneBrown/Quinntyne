// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using FluentValidation;

namespace Quinntyne.Models.Content;

public class UpdateContentRequestValidator: AbstractValidator<UpdateContentRequest>
{
    public UpdateContentRequestValidator(){
        RuleFor(x => x.ContentId).NotNull();
        RuleFor(x => x.Name).NotNull().NotEmpty();

    }

}

