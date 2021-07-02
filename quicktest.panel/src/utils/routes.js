import Homepage from "@/components/Homepage";
import HelloWorld from "@/components/HelloWorld";
import TestCasePanel from "@/containers/TestCasePanel";
import ReportsPage from "@/containers/ReportsPage";
import SingleReportPage from "@/containers/SingleReportPage";
import TestCasePage from "@/containers/TestCasePage";

export const routes = [
    {path: '/', component: Homepage, name: "Homepage", props: true},
    {path: '/hello', component: HelloWorld, name: "HelloWorld", props: true},
    {path: '/development', component: TestCasePanel, name: "TestCasePanel", props: true},
    {path: '/reports', component: ReportsPage, name: "ReportsPage", props: true},
    {path: '/testcase', component: TestCasePage, name: "TestCasePage", props: true},
    {path: '/report/description', component: SingleReportPage, name: "SingleReportPage", props: true}

]
