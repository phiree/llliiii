// File:    标志图片.cs
// Author:  suibianba
// Created: 2015年11月11日 15:15:42
// Purpose: Definition of Class 标志图片

using System;

/// 标志的文件，
public class 标志图片
{
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