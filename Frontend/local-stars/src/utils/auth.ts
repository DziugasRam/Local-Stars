import { serverUrl } from "../configuration";

// TODO: replace with a service class/move to http-service

export async function authFetch(url: string, options: RequestInit = {}, forceSignIn = true) {
    if(!options.credentials) options.credentials = "include";
    const resp = await fetch(url, options);
    if(resp.status == 401 && forceSignIn) await signIn();
    return resp;
}

export function signIn() {
    const encodedUrl = encodeURIComponent(document.location.href);
    document.location.href = `${document.location.origin}/signin?returnUrl=${encodedUrl}`;
    return new Promise(() => {});
}

export async function logOut() {
    const options: RequestInit = {
        method: "POST"
    }
    const url = `${serverUrl}/api/user/signout`;
    await authFetch(url, options, false);
    await signIn();
}