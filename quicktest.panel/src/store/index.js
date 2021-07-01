import Vue from 'vue';
import Vuex from 'vuex';
import createPersistedState from "vuex-persistedstate";
import {api} from "@/utils/api"


Vue.use(Vuex);

const state={
    testcases:{},
    reports:[]
};

 const getters = {
 };

 const mutations ={
     setTestcases(state,testcases){
         state.testcases = testcases;
     },
     setReports(state,reports){
       state.reports = reports
     }
 };

 const actions = {
     async getTestcases({commit}){
         const {data} = await api.get("testcase");
         commit("setTestcases",data);
     },
     async getReportsOfTestcase({commit},testcaseId){
        const {data} = await api.get(`testcase/reports/${testcaseId}`);
        commit("setReports",data);
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
