- Integrate vue.js into into .net core mvc web app 
	- Uses razor views as vue components
	- No webpack or node


    ### Html to render component
    ```
        <hello-world></hello-world>
    ```

    ### Include vue from cdn
    ```
    <script src="https://cdnjs.cloudflare.com/ajax/libs/vue/3.0.11/vue.global.js"></script>
    ```

    ### Create App
    ```
        const { createApp } = Vue;
        const app = createApp({});
    ```

    ### Include Component
    ```
        <partial name="Components/HelloWorld/hello-world" />
    ```

    ### Mount Application    
    ```
        app.mount('#app');
    ```
