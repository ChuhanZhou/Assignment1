﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Assignment1.Models;
using FileData;
using Models;

namespace Assignment1.Data
{
    public class ModelManager : IModelManager
    {
        private ModelPackage modelPackage;
        private readonly string dataFileName;

        public ModelManager()
        {
            modelPackage = new ModelPackage();
            dataFileName = "FileData.json";
            readData();
        }

        private void readData()
        {
            if (!File.Exists(dataFileName))
            {
                
                //List<OldFamily> families = new List<OldFamily>(new FileContext().Families);
                //foreach (var family in families)
                //{
                //    modelPackage.FamilyList.AddFamily(family.ConvertToFamily());
                //}
                //List<Adult> adults = new List<Adult>(new FileContext().Adults);
                //foreach (var adult in adults)
                //{
                //    modelPackage.AdultList.AddAdult(adult);
                //}
                
                UpdateData();
            }
            string json = File.ReadAllText(dataFileName);
            modelPackage = JsonSerializer.Deserialize<ModelPackage>(json);
        }

        private void UpdateData()
        {
            string json = JsonSerializer.Serialize(modelPackage,new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(dataFileName,json);
        }

        public string AddUser(User newUser)
        {
            string result = modelPackage.UserList.AddUser(newUser);
            UpdateData();
            return result;
        }

        public bool Login(User user)
        {
            return modelPackage.UserList.CheckPassword(user);
        }

        public UserList GetAllUser()
        {
            return modelPackage.UserList.GetAllUser();
        }

        public string UpdatePassword(User oldUser,User newUser)
        {
            string result = modelPackage.UserList.UpdatePassword(oldUser,newUser);
            UpdateData();
            return result;
        }

        public void RemoveUser(User user)
        {
            modelPackage.UserList.RemoveUser(user);
            UpdateData();
        }

        public string AddFamily(Family newFamily)
        {
            string result = modelPackage.FamilyList.AddFamily(newFamily);
            UpdateData();
            return result;
        }

        public FamilyList GetAllFamily()
        {
            return modelPackage.FamilyList.GetAllWithFamilyList();
        }

        public string UpdateFamily(Family oldFamily, Family newFamily)
        {
            string result = modelPackage.FamilyList.UpdateFamily(oldFamily, newFamily);
            UpdateData();
            return result;
        }

        public void RemoveFamily(Family family)
        {
            modelPackage.FamilyList.RemoveFamily(family);
            UpdateData();
        }

        public string AddAdult(Adult newAdult)
        {
            if (modelPackage.ChildList.GetChildById(newAdult.Id)==null)
            {
                string result = modelPackage.AdultList.AddAdult(newAdult);
                UpdateData();
                return result;
            }
            return "This id is used.";
        }

        public AdultList GetAllAdult()
        {
            return modelPackage.AdultList.GetAllWithAdultList();
        }

        public string AddChild(Child newChild)
        {
            if (modelPackage.AdultList.GetAdultById(newChild.Id)==null)
            {
                string result = modelPackage.ChildList.AddChild(newChild);
                UpdateData();
                return result;
            }
            return "This id is used.";
        }

        public ChildList GetAllChild()
        {
            return modelPackage.ChildList.GetAllWithChildList();
        }

        public string UpdatePerson(Person newPerson)
        {
            string result = null;
            if (modelPackage.AdultList.GetAdultById(newPerson.Id)!=null)
            {
                result = modelPackage.AdultList.UpdateAdult((Adult) newPerson);
                if (result==null)
                {
                    foreach (var family in modelPackage.FamilyList.GetFamilyListByPerson(newPerson).families)
                    {
                        family.Adults.UpdateAdult((Adult) newPerson);
                    }
                }
            }
            else if (modelPackage.ChildList.GetChildById(newPerson.Id)!=null)
            {
                result = modelPackage.ChildList.UpdateChild((Child) newPerson);
                if (result==null)
                {
                    foreach (var family in modelPackage.FamilyList.GetFamilyListByPerson(newPerson).families)
                    {
                        family.Children.UpdateChild((Child) newPerson);
                    }
                }
            }
            UpdateData();
            return result;
        }

        public void RemovePerson(Person person)
        {
            modelPackage.AdultList.RemoveAdult(person);
            modelPackage.ChildList.RemoveChild(person);
            foreach (var family in modelPackage.FamilyList.families)
            {
                family.Adults.RemoveAdult(person);
                family.Children.RemoveChild(person);
            }
            UpdateData();
        }
    }
}