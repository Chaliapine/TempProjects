Article (id, name)
Tag (id, name)
ArticleTag(articleId, tagId)

select a.name, b.name from Article a
left join ArticleTag b on a.Id = b.articleId
left join Tag c on b.tagId = c.id