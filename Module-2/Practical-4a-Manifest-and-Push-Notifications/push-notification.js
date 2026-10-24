// Request notification permission
async function requestPermission() {

const permission = await Notification.requestPermission();
if (permission === 'granted') {
console.log('Notification permission granted');
subscribeUser();
} else {
console.log('Notification permission denied');
}
}
// Subscribe to push notifications
async function subscribeUser() {
const registration = await navigator.serviceWorker.ready;
const subscription = await registration.pushManager.subscribe({
userVisibleOnly: true,
applicationServerKey: urlBase64ToUint8Array('YOUR_VAPID_PUBLIC_KEY')
});
console.log('Push subscription:', JSON.stringify(subscription));
// Send subscription to server
await fetch('/api/subscribe', {
method: 'POST',
headers: { 'Content-Type': 'application/json' },
body: JSON.stringify(subscription)
});
}
// Show local notification demo
function showNotification() {
if (Notification.permission === 'granted') {
new Notification('MyApp Notification', {
body: 'You have a new message!',
icon: '/icons/icon-192x192.png',
badge: '/icons/badge.png',
tag: 'demo-notification'
});
}
}
