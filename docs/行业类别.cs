// File:    行业类别.cs
// Author:  suibianba
// Created: 2015年11月11日 15:20:41
// Purpose: Definition of Class 行业类别

using System;

public class 行业类别
{
   public System.Collections.Generic.List<组织> 组织;
   
   /// <summary>
   /// Property for collection of 组织
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<组织> 组织
   {
      get
      {
         if (组织 == null)
            组织 = new System.Collections.Generic.List<组织>();
         return 组织;
      }
      set
      {
         RemoveAll组织();
         if (value != null)
         {
            foreach (组织 o组织 in value)
               Add组织(o组织);
         }
      }
   }
   
   /// <summary>
   /// Add a new 组织 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add组织(组织 new组织)
   {
      if (new组织 == null)
         return;
      if (this.组织 == null)
         this.组织 = new System.Collections.Generic.List<组织>();
      if (!this.组织.Contains(new组织))
         this.组织.Add(new组织);
   }
   
   /// <summary>
   /// Remove an existing 组织 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove组织(组织 old组织)
   {
      if (old组织 == null)
         return;
      if (this.组织 != null)
         if (this.组织.Contains(old组织))
            this.组织.Remove(old组织);
   }
   
   /// <summary>
   /// Remove all instances of 组织 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll组织()
   {
      if (组织 != null)
         组织.Clear();
   }

}