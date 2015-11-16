// File:    组织.cs
// Author:  suibianba
// Created: 2015年11月11日 15:17:37
// Purpose: Definition of Class 组织

using System;

/// 标志所属的组织
public class 组织
{
   public System.Collections.Generic.List<标志> 标志;
   
   /// <summary>
   /// Property for collection of 标志
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<标志> 标志
   {
      get
      {
         if (标志 == null)
            标志 = new System.Collections.Generic.List<标志>();
         return 标志;
      }
      set
      {
         RemoveAll标志();
         if (value != null)
         {
            foreach (标志 o标志 in value)
               Add标志(o标志);
         }
      }
   }
   
   /// <summary>
   /// Add a new 标志 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add标志(标志 new标志)
   {
      if (new标志 == null)
         return;
      if (this.标志 == null)
         this.标志 = new System.Collections.Generic.List<标志>();
      if (!this.标志.Contains(new标志))
         this.标志.Add(new标志);
   }
   
   /// <summary>
   /// Remove an existing 标志 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove标志(标志 old标志)
   {
      if (old标志 == null)
         return;
      if (this.标志 != null)
         if (this.标志.Contains(old标志))
            this.标志.Remove(old标志);
   }
   
   /// <summary>
   /// Remove all instances of 标志 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll标志()
   {
      if (标志 != null)
         标志.Clear();
   }
   public System.Collections.Generic.List<评论> 评论;
   
   /// <summary>
   /// Property for collection of 评论
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<评论> 评论
   {
      get
      {
         if (评论 == null)
            评论 = new System.Collections.Generic.List<评论>();
         return 评论;
      }
      set
      {
         RemoveAll评论();
         if (value != null)
         {
            foreach (评论 o评论 in value)
               Add评论(o评论);
         }
      }
   }
   
   /// <summary>
   /// Add a new 评论 in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void Add评论(评论 new评论)
   {
      if (new评论 == null)
         return;
      if (this.评论 == null)
         this.评论 = new System.Collections.Generic.List<评论>();
      if (!this.评论.Contains(new评论))
         this.评论.Add(new评论);
   }
   
   /// <summary>
   /// Remove an existing 评论 from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void Remove评论(评论 old评论)
   {
      if (old评论 == null)
         return;
      if (this.评论 != null)
         if (this.评论.Contains(old评论))
            this.评论.Remove(old评论);
   }
   
   /// <summary>
   /// Remove all instances of 评论 from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAll评论()
   {
      if (评论 != null)
         评论.Clear();
   }

}