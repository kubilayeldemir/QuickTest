import Vue from 'vue';
import Vuex from 'vuex';
import createPersistedState from "vuex-persistedstate";


Vue.use(Vuex);

const state={};

 const getters = {
 };

 const mutations ={};

 const actions = {};

const store = new Vuex.Store({
    state,
    getters,
    mutations,
    actions,
    plugins: [createPersistedState()]
})
export default store;
