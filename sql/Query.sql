select Products.Name, Category.Name 
	from (Products left join Relations on 
			Relations.IdProduct = Products.Id 
			left join Category on 
			Relations.IdCategory = Category.Id)
