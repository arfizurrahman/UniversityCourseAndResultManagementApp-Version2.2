﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityCourseAndResultManagementApp.Gateway;
using UniversityCourseAndResultManagementApp.Models;

namespace UniversityCourseAndResultManagementApp.Manager
{
    public class ClassRoomManager
    {
        ClassRoomGateway aClassRoomGateway = new ClassRoomGateway();
        

        public List<Course> GetAllCourses(ClassRoom classRoom)
        {
            return aClassRoomGateway.GetAllCourses(classRoom);
        }

        public List<ClassRoom> GetAllClassRooms(int id)
        {
            return aClassRoomGateway.GetAllClassRooms(id);
        }


        public string UnAllocateClassRoom()
        {
            if (aClassRoomGateway.IsRoomAllocated())
            {
                
                int rowAffected = aClassRoomGateway.UnAllocateClassRoom();
                if (rowAffected > 0)
                {
                    return "Room unallocated";
                }
                else
                {
                    return "Room unallocation falied";
                }

            }
            else
            {
                return "Room Already unallocated";
            }
            
        }
        /*public List<Course> GetAllCourses(ClassRoom classRoom)
        {
            return aClassRoomGateway.GetAllCourses(classRoom);
        }

        public List<ClassRoom> GetAllClassRooms(int id)
        {
            return aClassRoomGateway.GetAllClassRooms(id);
        }*/
    }
}