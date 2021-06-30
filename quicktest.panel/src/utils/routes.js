import Homepage from "@/components/Homepage";
import HelloWorld from "@/components/HelloWorld";
import TestCasePanel from "@/containers/TestCasePanel";

export const routes = [
    {path: '/', component: Homepage, name: "Homepage", props: true},
    {path: '/hello', component: HelloWorld, name: "HelloWorld", props: true},
    {path: '/development', component: TestCasePanel, name: "TestCasePanel", props: true},


]
