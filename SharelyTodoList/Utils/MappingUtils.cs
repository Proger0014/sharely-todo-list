using SharelyTodoList.Entities.AccessToken;
using SharelyTodoList.Entities.Group;
using SharelyTodoList.Models;

namespace SharelyTodoList.Utils;

public static class MappingUtils
{
    // AccessTokens
    public static AccessTokenModel? MapToModel(AccessToken? source)
    {
        return source is not null 
            ? new AccessTokenModel()
            {
                Token = source.Token,
                GroupId = source.GroupId
            }
            : null;
    }

    public static AccessToken? MapToEntity(AccessTokenModel? source)
    {
        return source is not null 
            ? new AccessToken()
            {
                Token = source.Token,
                GroupId = source.GroupId
            }
            : null;
    }
    
    // Groups
    public static GroupModel? MapToModel(Group? source)
    {
        return source is not null
            ? new GroupModel()
            {
                Id = source.Id,
                Name = source.Name,
                Password = source.Password
            }
            : null;
    }

    public static Group? MapToEntity(GroupModel? source)
    {
        return source is not null 
            ? new Group()
            {
                Id = source.Id,
                Name = source.Name,
                Password = source.Password
            }
            : null;
    }
}