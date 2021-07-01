import Vue from 'vue'
import App from './App.vue'
import store from './store'
import Router from 'vue-router'
import {routes} from "@/utils/routes";
import 'bootstrap/dist/css/bootstrap.min.css'

Vue.use(Router);
Vue.use(require('vue-moment'));


const router = new Router({
  mode: 'history',
  base: __dirname,
  routes: routes
});


new Vue({
  render: h => h(App),
  store,
  router:router
}).$mount('#app')
