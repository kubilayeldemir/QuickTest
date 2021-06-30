import Homepage from "@/components/Homepage";
import HelloWorld from "@/components/HelloWorld";

export const routes = [
    {path: '/', component: Homepage, name: "Homepage", props: true},
    {path: '/hello', component: HelloWorld, name: "HelloWorld", props: true}
]
