function getArticleGenerator(articles) {
    
    return function print(){
        if(articles.length > 0){
            let content = document.getElementById('content')
            let article = document.createElement('article')
            article.textContent = articles.shift();
            content.appendChild(article);
        }
    }
}
