import Vue from 'vue';
import Vuex from 'vuex';
// import createPersistedState from "vuex-persistedstate";
import {api} from "@/utils/api"


Vue.use(Vuex);

const state = {
    testcases: {},
    reports: [],
    testToCreate: {
        steps: []
    },
    testCreated: {}
};

const getters = {};

const mutations = {
    setTestcases(state, testcases) {
        state.testcases = testcases;
    },
    setReports(state, reports) {
        state.reports = reports;
    },
    setCreatedTestCase(state, createdTestCase) {
        state.testCreated = createdTestCase;
    },
    pushStepToCreateList(state, step) {
        state.testToCreate.steps.push(step)
    },
    setTestCaseToCreate(state, testCaseToCreate) {
        state.testToCreate = testCaseToCreate
    }
};

const actions = {
    async getTestcases({commit}) {
        const {data} = await api.get("testcase");
        commit("setTestcases", data);
    },
    async getReportsOfTestcase({commit}, testcaseId) {
        const {data} = await api.get(`testcase/reports/${testcaseId}`);
        commit("setReports", data);
    },
    async saveTestCase({commit, state}) {
        const {data} = await api.post('testcase', state.testToCreate)
        commit("setCreatedTestCase", data)
    }
};

const store = new Vuex.Store({
    state,
    getters,
    mutations,
    actions
    // plugins: [createPersistedState()]
})
export default store;
