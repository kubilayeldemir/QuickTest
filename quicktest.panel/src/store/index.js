import Vue from 'vue';
import Vuex from 'vuex';
import createPersistedState from "vuex-persistedstate";
import {api} from "@/utils/api"


Vue.use(Vuex);

const state={
    testcases:{}
};

 const getters = {
 };

 const mutations ={
     setTestcases(state,testcases){
         state.testcases = testcases;
     }
 };

 const actions = {
     async getTestcases({commit}){
         const {data} = await api.get("testcase");
         commit("setTestcases",data);

     }
 };

const store = new Vuex.Store({
    state,
    getters,
    mutations,
    actions,
    plugins: [createPersistedState()]
})
export default store;
