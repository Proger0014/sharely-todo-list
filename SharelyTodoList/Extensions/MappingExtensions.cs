using SharelyTodoList.Entities.AccessToken;
using SharelyTodoList.Entities.Group;
using SharelyTodoList.Models;
using SharelyTodoList.Utils;

namespace SharelyTodoList.Extensions;

public static class MappingExtensions
{
    // AccessTokens
    public static AccessTokenModel? MapToModel(this AccessToken? source)
    {
        return MappingUtils.MapToModel(source);
    }

    public static AccessToken? MapToEntity(this AccessTokenModel? source)
    {
        return MappingUtils.MapToEntity(source);
    }
    
    // Groups
    public static GroupModel? MapToModel(this Group? source)
    {
        return MappingUtils.MapToModel(source);
    }

    public static Group? MapToEntity(this GroupModel? source)
    {
        return MappingUtils.MapToEntity(source);
    }
}