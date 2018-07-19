﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAMTeam.Data.Repositories
{
    public class ArticlesRepository
    {
        public Article Add(Article article)
        {
            Article dbArticle;
            try
            {
                using (var context = new AMTeamEntities())
                {
                    dbArticle = context.Articles.Add(article);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                throw;
            }

            return dbArticle;
        }

        public Article GetById(int Id)
        {
            Article dbArticle;
            try
            {
                using (var context = new AMTeamEntities())
                {
                    dbArticle = context.Articles.FirstOrDefault(c => c.ArticleId == Id);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                throw;
            }

            return dbArticle;
        }

        public Article Update(Article article)
        {
            try
            {
                using (var context = new AMTeamEntities())
                {
                    //var unUpdate = context.Articles.FirstOrDefault(c => c.Author == upd.Author);
                    if(article != null)
                    {
                        context.Articles.Attach(article);
                        context.Entry(article).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                throw;
            }
            return article;
        }

        public bool Delete(int id)
        {
            Article dbArticle;
            try
            {
                using (var context = new AMTeamEntities())
                {
                    dbArticle = context.Articles.FirstOrDefault(c => c.ArticleId == id);
                    context.Articles.Remove(dbArticle);
                    context.SaveChanges();
                    
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                throw;
            }
            return dbArticle != null ? true : false;
        }

        public List<Article> GetAll()
        {
            List<Article> articles;
            try
            {
                using (var context = new AMTeamEntities())
                {
                     articles = context.Articles.ToList();
                    
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                throw;
            }
            return articles;
        }
    }
}
