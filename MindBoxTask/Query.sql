select a.Name As ArticleName, ATN.TagName
from dbo.Article as A
left join 
(
    select AT.ArticleId, T.Name as TagName
    from dbo.ArtcileTag as AT 
    inner join dbo.Tag as T on AT.TagId = T.Id
) ATN on A.ID = ATN.ArticleId


