function solve() {
    const addButtons = document.getElementsByClassName('product-add');
    const checkoutButton = document.getElementsByClassName('checkout')[0];
    const cart = document.querySelector('textarea');

    let totalPrice = 0;
    let products = [];

    for(let button of addButtons){
        button.addEventListener('click', addToCart)
    }

    function addToCart(e){

        const product = e.currentTarget.parentNode;
        const productPrice = product.querySelector('.product-line-price').textContent;
        const productTitle = product.querySelector('.product-title').textContent;
        
        totalPrice += Number(productPrice);

        if(!products.includes(productTitle)){
            products.push(productTitle);
        }

        cart.value += `Added ${productTitle} for ${productPrice} to the cart.\n`;

    }

    checkoutButton.addEventListener('click', () => {

        cart.value += `You bought ${products.join(', ')} for ${totalPrice.toFixed(2)}\n`;

        for(let button of addButtons){
            button.removeEventListener('click', addToCart)
        }
    })
}
