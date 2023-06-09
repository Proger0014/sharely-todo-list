﻿using SharelyTodoList.Constants;
using SharelyTodoList.Exceptions;
using SharelyTodoList.Interfaces.Repositories;
using SharelyTodoList.Interfaces.Services;
using SharelyTodoList.Models;

namespace SharelyTodoList.Services;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _groupRepository;

    public GroupService(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }

    public async Task<GroupModel> GetById(long groupId)
    {
        var existsGroup =  await _groupRepository.GetById(groupId);

        if (existsGroup is null)
        {
            throw new NotFoundException(string.Format(
                ExceptionMessages.EntityNotFound, nameof(GroupModel), groupId));
        }

        return existsGroup;
    }

    public async Task<long> CreateGroup(string name, string password)
    {
        var newGroup = new GroupModel()
        {
            Name = name,
            Password = password
        };

        return await _groupRepository.Create(newGroup);
    }

    public async Task<bool> IsValidPassword(long groupId, string password)
    {
        var existsGroup = await _groupRepository.GetById(groupId);

        return existsGroup?.Password == password;
    }
}
