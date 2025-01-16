let promise = new Promise((res, rej) => 
    setTimeout(() => {
        res('alo');
    }, 1000))

    async function demo() {
        let res = await promise;
        
        console.log('hello');
        console.log(res);
    }
