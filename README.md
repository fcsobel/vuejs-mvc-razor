# vuejs-mvc-razor
- Integrate vue.js into into .net core mvc web app 
	- Uses razor views as vue components
	- No webpack or node

    ### Include vue3 from cdn

    ```
    <!--vue3-->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/vue/3.0.11/vue.global.js"></script>
    ```

    ### Create App

    ```
    <script type="text/javascript">
        // minimal vue3 app startup
        const { createApp } = Vue;
        const app = createApp({});
    </script>
    ```
    ### Mount Application
    
    ```
    <script type="text/javascript">
        // mount view app after components have been rendered
        app.mount('#app');
    </script>
    ```
